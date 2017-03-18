using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Circle : MonoBehaviour
{
    public UI2DSprite timer;
    
    public Vector3 goPos;
    public GameObject bar;
    public List<Vector3> tailsPos;
    public GameObject[] tailObjs;

    public GameObject success;
    public GameObject failed;

    public int[] stage_Num;
    public GameManeger Stage_;

    public Animator[] decAnim;


    void Start()
    {
        goPos = Vector2.up;

        switch(Stage_.GameStage)
        {
            case 0:
                maxTime = 40; break;
            case 1:
                maxTime = 50; break;
            case 2:
                maxTime = 150; break;
            case 3:
                maxTime = 55; break;
            case 4:
                maxTime = 135; break;
            case 5:
                maxTime = 70; break;
            case 6:
                maxTime = 25; break;
            case 7:
                maxTime = 50; break;
            case 8:
                maxTime = 40; break;
        }

        timer.fillAmount = 0f;
        for (int i = 0; i < 17; i++)
            tailsPos.Add(transform.position);
        tailObjs[0].transform.position = tailsPos[6];
        tailObjs[1].transform.position = tailsPos[8];
        tailObjs[2].transform.position = tailsPos[10];
        tailObjs[3].transform.position = tailsPos[12];
        tailObjs[4].transform.position = tailsPos[14];
    }

    Vector2 beginPos;
    bool ready = false;
    public bool start = false;
    bool dec = false;

    float maxTime = 0;
    float myTime = 0;
    void Update()
    {
        if (start)
            if (ready)
            {
                myTime += Time.deltaTime;
                timer.fillAmount -= Time.deltaTime / maxTime; // *Time.deltaTime;

                if (tailsPos.Count > 17)
                    tailsPos.RemoveAt(0);
                tailsPos.Add(transform.position);
                tailObjs[0].transform.position = tailsPos[6];
                tailObjs[1].transform.position = tailsPos[8];
                tailObjs[2].transform.position = tailsPos[10];
                tailObjs[3].transform.position = tailsPos[12];
                tailObjs[4].transform.position = tailsPos[14];

                Vector2 bPos;

                if (Input.GetMouseButtonDown(0))
                {
                    bPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                }
                if (Input.GetMouseButton(0))
                {
                    if (beginPos.x > 0)
                    {
                        bar.transform.Rotate(new Vector3(0, 0, Time.deltaTime * 140));
                    }
                    else
                    {
                        bar.transform.Rotate(new Vector3(0, 0, Time.deltaTime * -140));
                    }
                    beginPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                }
                else if (Input.GetMouseButtonDown(0))
                {
                    beginPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                }

                transform.position += goPos * Time.deltaTime * 5;

                if (!dec)
                if (timer.fillAmount <= 0)
                {
                    decAnim[0].SetBool("Done", true);
                    if (failed.transform.localPosition.x <= 0)
                        failed.transform.localPosition = new Vector3(0, -1, 0);
                    dec = true;
                }
                else if (stage_Num[Stage_.GameStage] <= 0)
                {
                    decAnim[1].SetBool("Done", true);
                    if (success.transform.localPosition.x <= 0)
                        success.transform.localPosition = new Vector3(0, -1, 0);
                    dec = true;
                }
            }
            else
            {
                timer.fillAmount += 0.01f;
                if (timer.fillAmount >= 1)
                    ready = true;
            }

    }

    public void keepgo()
    {
        if(Stage_.GameStage<12)
        {
            Stage_.GameStage++;
            Singleton.getInstance.stageNum = Stage_.GameStage;
            Singleton.getInstance.isReplay = true;
            DontDestroyOnLoad(Singleton.getInstance.gameObject);
            Application.LoadLevel("Scene");
        }
    }
    public void retry()
    {
        Singleton.getInstance.isReplay = true;
        DontDestroyOnLoad(Singleton.getInstance.gameObject);
        Application.LoadLevel("Scene");
    }
    public void go_main()
    {
        Application.LoadLevel("Scene");
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        goPos = Vector3.Reflect(goPos, (coll.contacts[0].point - (Vector2)transform.position).normalized);
    }
}