using UnityEngine;
using System.Collections;

public class B_Block : MonoBehaviour
{

    public Sprite[] Sprite_B_Block;
    public int[] stage_Num;
    public GameObject anim;
    public int Hp;
    public AudioClip impact;
    public GameObject bomb;

    AudioSource audio;

    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    void check()
    {
        if (Hp == 2)//HP 2 가 될시 스프라이트 바꿈
        {
            transform.GetComponent<SpriteRenderer>().sprite = Sprite_B_Block[1];
        }
        if (Hp == 1)//HP 1 가 될시 스프라이트 바꿈
        {
            transform.GetComponent<SpriteRenderer>().sprite = Sprite_B_Block[0];
        }
        if (Hp <= 0)//HP 0 가 될시 스프라이트 바꿈
        {
            Instantiate(bomb, transform.position, Quaternion.identity);

            //Debug.Log(GameObject.Find("Circle").GetComponent<Circle>().stage_Num[GameObject.Find("GameManager").GetComponent<GameManeger>().GameStage]);
            GameObject.Find("Circle").GetComponent<Circle>().stage_Num[GameObject.Find("GameManager").GetComponent<GameManeger>().GameStage]--;
            Paticle();
            Destroy(gameObject);
        }
    }
    void Paticle()
    {
        Instantiate(anim, new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z), Quaternion.identity);
    }

    //충돌시 들어오는곳
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
            audio.PlayOneShot(impact);
            Hp--;
            check();
        }
    }

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.CompareTag("Bomb"))
    //    {
    //        Hp--;
    //        check();
    //    }
    //}

    public void collBomb()
    {
        Hp--;
        check();
    }
}
