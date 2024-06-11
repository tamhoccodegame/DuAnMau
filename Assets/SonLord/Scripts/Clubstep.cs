using System.Collections;
using UnityEngine;

public class Clubstep : MonoBehaviour
{
    public Transform mouth; // Gán Transform của miệng trong Inspector
    public float openPositionY = 1f; // Vị trí Y khi miệng mở
    public float closedPositionY = 0f; // Vị trí Y khi miệng đóng
    public float transitionTime = 0.5f; // Thời gian di chuyển từ mở sang đóng và ngược lại

    void Start()
    {
        // Bắt đầu hoạt hình miệng
        StartCoroutine(MouthAnimation());
    }

    IEnumerator MouthAnimation()
    {
        while (true)
        {
            // Di chuyển miệng đến vị trí mở
            yield return MoveMouth(openPositionY);

            // Di chuyển miệng đến vị trí đóng
            yield return MoveMouth(closedPositionY);
        }
    }

    IEnumerator MoveMouth(float targetPositionY)
    {
        float startTime = Time.time;
        float startPostionY = mouth.localPosition.y;

        while (Time.time - startTime < transitionTime)
        {
            float newY = Mathf.Lerp(startPostionY, targetPositionY, (Time.time - startTime) / transitionTime);
            mouth.localPosition = new Vector3(mouth.localPosition.x, newY, mouth.localPosition.z);
            yield return null;
        }

        mouth.localPosition = new Vector3(mouth.localPosition.x, targetPositionY, mouth.localPosition.z);
    }
}
