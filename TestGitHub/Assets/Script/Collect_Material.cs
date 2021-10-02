using UnityEngine;
using UnityEngine.UI;

public class Collect_Material : MonoBehaviour
{
    private int point = 0;
    public Text Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Collectible")
        {
            point++;
            Text.text = point.ToString();
            Destroy(other.gameObject);
        }
    }
}
