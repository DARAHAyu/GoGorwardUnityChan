using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    AudioSource audioSource;

    // キューブのPrefab
    public GameObject CubePrefab;

    // UnityちゃんのPrefab
    public GameObject Unitychan2D;

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // 地面の位置
    private float groundlevel = -3.0f;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSourceを取得する
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if(transform.position.y < this.deadLine)
        {
            Destroy(gameObject);
        }

        // キューブが着地しているかどうかを調べる
        bool isGround = (transform.position.y > this.groundlevel) ? false : true;


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("test");

        if (other.gameObject.tag != "Unitychan")
        {
            Debug.Log("NotUnitychan");
            audioSource.Play();
        }

    }

}
