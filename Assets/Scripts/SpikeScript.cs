using UnityEngine;

public class SpikeScript : MonoBehaviour
{

    public SpikeGenerator spikeGenerator;

    + public spikeGenerator:SpikeGenerator
    
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * spikeGenerator.CurrentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("nextLine"))
        {
            spikeGenerator.GenerateNextSpikeWithGap();  
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }

}
