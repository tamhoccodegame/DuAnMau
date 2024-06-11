using System.Collections;
using UnityEngine;

public class Clubstep : MonoBehaviour
{
    public Transform mouth; // Gán Transform của miệng trong Inspector
    public float openPositionY = 1f; // Vị trí Y khi miệng mở
    public float closedPositionY = 0f; // Vị trí Y khi miệng đóng
    public float openTime = 3f; // Thời gian miệng ở trạng thái mở
    public float closeTime = 0.3f; // Thời gian miệng ở trạng thái đóng
    public float speed = 0.1f; // Tốc độ di chuyển của miệng

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
            while (Mathf.Abs(mouth.localPosition.y - openPositionY) > 0.01f)
            {
                mouth.localPosition = Vector3.MoveTowards(mouth.localPosition, new Vector3(mouth.localPosition.x, openPositionY, mouth.localPosition.z), speed);
                yield return null;
            }
            yield return new WaitForSeconds(openTime);

            // Di chuyển miệng đến vị trí đóng
            while (Mathf.Abs(mouth.localPosition.y - closedPositionY) > 0.01f)
            {
                mouth.localPosition = Vector3.MoveTowards(mouth.localPosition, new Vector3(mouth.localPosition.x, closedPositionY, mouth.localPosition.z), speed);
                yield return null;
            }
            yield return new WaitForSeconds(closeTime);
        }
    }
}
