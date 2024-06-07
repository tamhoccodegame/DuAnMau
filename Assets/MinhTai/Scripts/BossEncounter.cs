using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BossTriggerArea : MonoBehaviour
{
    public GameObject[] walls; // Các bức tường sẽ xuất hiện khi người chơi gặp boss
    public GameObject boss; // Đối tượng boss
    private bool bossFightStarted = false;

    void Start()
    {
        // Đảm bảo rằng các bức tường bị tắt khi game bắt đầu
        foreach (GameObject wall in walls)
        {
            wall.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Kiểm tra nếu người chơi bước vào khu vực boss
        if (other.CompareTag("Player") && !bossFightStarted)
        {
            StartBossFight();
        }
    }

    void StartBossFight()
    {
        bossFightStarted = true;

        // Kích hoạt các bức tường để chặn lối ra
        foreach (GameObject wall in walls)
        {
            wall.SetActive(true);
        }

        //// Bắt đầu hành vi của boss (tùy chọn)
        //if (boss != null)
        //{
        //    boss.GetComponent<Boss>()?.StartBehavior();
        //}
    }

    // Gọi hàm này khi boss bị đánh bại
    public void EndBossFight()
    {
        // Tắt các bức tường khi boss bị đánh bại
        foreach (GameObject wall in walls)
        {
            wall.SetActive(false);
        }

        bossFightStarted = false; // Reset trạng thái để tái sử dụng nếu cần
    }
}
