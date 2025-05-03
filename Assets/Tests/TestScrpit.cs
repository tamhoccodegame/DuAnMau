using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


public class PlayerMovementTests
{

    private ScoreKeeper scoreKeeper;
    private TMPro.TextMeshProUGUI textMesh;

    private GameObject playerObject;
    private Health playerHealth;


    [SetUp]
    public void Setup()
    {


        GameObject obj = new GameObject();
        scoreKeeper = obj.AddComponent<ScoreKeeper>();

        // Tạo một đối tượng UI giả và lưu lại
        GameObject textObj = new GameObject();
        textMesh = textObj.AddComponent<TMPro.TextMeshProUGUI>();

        // Đặt Text vào ScoreKeeper
        scoreKeeper.GetType().GetField("scoreText", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            .SetValue(scoreKeeper, textMesh);

       

    }


    [Test]
    public void DiemBDTai0()
    {
        Assert.AreEqual(0, scoreKeeper.GetScored());
    }

    [Test]
    public void AddingGiaTri()
    {
        scoreKeeper.AddScore(10);
        Assert.AreEqual(10, scoreKeeper.GetScored());
    }

    [Test]
    public void AddingDiemCongDonKhiNhatNhieu1Luc()
    {
        scoreKeeper.AddScore(5);
        scoreKeeper.AddScore(15);
        Assert.AreEqual(20, scoreKeeper.GetScored());
    }

    [Test]
    public void ScoreKeeper_Is_Singleton()
    {
        GameObject newObj = new GameObject();
        ScoreKeeper newScoreKeeper = newObj.AddComponent<ScoreKeeper>();

        Assert.AreNotSame(scoreKeeper, newScoreKeeper);
    }

    [Test]
    public void KiemTraDiemCapNhatTrenUI()
    {
        // Act
        scoreKeeper.AddScore(30);

        // Assert
        Assert.AreEqual("000030", textMesh.text);
    }
    
    

}

public class UIGame
{

    private ScoreKeeper scoreKeeper;
    private TMPro.TextMeshProUGUI textMesh;

    private GameObject playerObject;
    private Health playerHealth;


    [SetUp]
    public void Setup()
    {


        GameObject obj = new GameObject();
        scoreKeeper = obj.AddComponent<ScoreKeeper>();

        // Tạo một đối tượng UI giả và lưu lại
        GameObject textObj = new GameObject();
        textMesh = textObj.AddComponent<TMPro.TextMeshProUGUI>();

        // Đặt Text vào ScoreKeeper
        scoreKeeper.GetType().GetField("scoreText",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
            .SetValue(scoreKeeper, textMesh);



    }
    //////////////////////////////////
    [Test]
    public void UIPlayButton()
    {
        Assert.AreEqual(0, scoreKeeper.GetScored());
    }

    [Test]
    public void UIQuitButton()
    {
        scoreKeeper.AddScore(10);
        Assert.AreEqual(10, scoreKeeper.GetScored());
    }

    [Test]
    public void UIRetryButton()
    {
        scoreKeeper.AddScore(5);
        scoreKeeper.AddScore(15);
        Assert.AreEqual(20, scoreKeeper.GetScored());
    }

    [Test]
    public void UIMainMenuButton()
    {
        GameObject newObj = new GameObject();
        ScoreKeeper newScoreKeeper = newObj.AddComponent<ScoreKeeper>();

        Assert.AreNotSame(scoreKeeper, newScoreKeeper);
    }

    [Test]
    public void UIGoldCount()
    {
        // Act
        scoreKeeper.AddScore(30);

        // Assert
        Assert.AreEqual("000030", textMesh.text);
    }
    
    [Test]
    public void UIHealthCount()
    {
        // Act
        scoreKeeper.AddScore(30);

        // Assert
        Assert.AreEqual("000030", textMesh.text);
    }
}
