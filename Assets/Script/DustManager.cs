using UnityEngine;
using TMPro;

public class DustManager : MonoBehaviour
{
    public static DustManager Instance;

    public int totalDust = 0;
    public TextMeshProUGUI winText;

    private void Awake()
    {
        Instance = this;
        if (winText != null)
            winText.gameObject.SetActive(false);
    }

    private void Start()
    {
        totalDust = GameObject.FindGameObjectsWithTag("Dirty").Length;
    }

    public void DustCollected()
    {
        totalDust--;
        if (totalDust <= 0 && winText != null)
        {
            winText.gameObject.SetActive(true);
        }
    }
}
