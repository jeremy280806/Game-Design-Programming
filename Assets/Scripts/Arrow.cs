using UnityEngine;

public class Bow : MonoBehaviour
{
    public float arrowSpeed = 5f;
    // Update is called once per frame

    private void Start() {
        Destroy(this.gameObject, 5f);
    }
    void Update()
    {
        transform.Translate(transform.right * Time.deltaTime * arrowSpeed);          
    }
}
