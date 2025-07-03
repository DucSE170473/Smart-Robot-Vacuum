using UnityEngine;

public class RobotClean : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Dirty"))
        {
            Destroy(other.gameObject);
            DustManager.Instance.DustCollected();
        }
    }
}
