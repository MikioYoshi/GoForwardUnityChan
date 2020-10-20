using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;

    private float deadLine = -10;

    
    //private AudioSource blockSound;

    // Start is called before the first frame update
    void Start()
    {
        //this.blockSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //cube同士が重なったとき、または、groundと接触したとき
        if (collision.gameObject.CompareTag("Cube") || collision.gameObject.CompareTag("Ground"))
        {
            //this.blockSound.Play();

            //cubeprefabにアタッチしているAudioSourceを再生
            GetComponent<AudioSource>().Play();
        }
    }
}
