using UnityEngine;

public class BackgroundDuplicator : MonoBehaviour
{
    public GameObject backgroundPrefab;
    public int numberOfDuplicates = 1;
    public float offset = 10f;

    void Start()
    {
        DuplicateBackground();
    }

    void DuplicateBackground()
    {
        for (int i = 1; i <= numberOfDuplicates; i++)
        {
            Vector3 newPosition = new Vector3(i * offset, 0f, 0f);
            Instantiate(backgroundPrefab, newPosition, Quaternion.identity);
        }
    }
}
