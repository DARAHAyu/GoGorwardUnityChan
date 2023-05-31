using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    AudioSource audioSource;

    // �L���[�u��Prefab
    public GameObject CubePrefab;

    // Unity������Prefab
    public GameObject Unitychan2D;

    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

    // �n�ʂ̈ʒu
    private float groundlevel = -3.0f;

    // Start is called before the first frame update
    void Start()
    {
        // AudioSource���擾����
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if(transform.position.y < this.deadLine)
        {
            Destroy(gameObject);
        }

        // �L���[�u�����n���Ă��邩�ǂ����𒲂ׂ�
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
