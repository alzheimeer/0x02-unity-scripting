using UnityEngine;

public class Rotator : MonoBehaviour
{
    private int score = 0;
    void OnTriggerEnter(Collider other)
    {

    }

    // Update is called once per frame
    void Update()
    {
     transform.RotateAround(transform.position, Vector3.up, score + 45 * Time.deltaTime);
    }
}
