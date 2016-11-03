using UnityEngine;
using System.Collections;

public class stage9 : MonoBehaviour {

    public GameObject _S_Block1;        //일반정사 1

    public GameObject _H_Block1;        //일반육각 1
    public GameObject _H_Block2;        //일반육각 2

    public GameObject _O_Block1;        //일반팔각 1
    public GameObject _O_Block2;        //일반팔각 2

    public GameObject B_S_Block1;       //폭발정사 1
    public GameObject B_S_Block2;       //폭발정사 2
    public GameObject B_S_Block3;       //폭발정사 3

    public GameObject T_S_Block1;       //타임정사 1

    public int Block_num = 27;

    GameObject parent;


    // Use this for initialization
    void Start()
    {
        parent = GameObject.Find("Block");

        GameObject Obj = (GameObject)Instantiate(_O_Block2, new Vector3(0, 0, 0), Quaternion.identity);
        Obj.transform.parent = parent.transform;
        GameObject Obj1 = (GameObject)Instantiate(_S_Block1, new Vector3(0 + (151f / 2 + 42f) / 100, 0, 0), Quaternion.identity);
        Obj1.transform.parent = parent.transform;
        GameObject Obj2 = (GameObject)Instantiate(_S_Block1, new Vector3(0 - (151f / 2 + 42f) / 100, 0, 0), Quaternion.identity);
        Obj2.transform.parent = parent.transform;
        GameObject Obj3 = (GameObject)Instantiate(_S_Block1, new Vector3(0, 0 + (151f / 2 + 42f) / 100, 0), Quaternion.identity);
        Obj3.transform.parent = parent.transform;
        GameObject Obj4 = (GameObject)Instantiate(_S_Block1, new Vector3(0, 0 - (151f / 2 + 42f) / 100, 0), Quaternion.identity);
        Obj4.transform.parent = parent.transform;
        GameObject Obj5 = (GameObject)Instantiate(_S_Block1, new Vector3(0 + (151f / 2 + 10f) / 100, 0 + 151f / 2 / 100, 0), Quaternion.Euler(0, 0, 45));
        Obj5.transform.parent = parent.transform;
        GameObject Obj6 = (GameObject)Instantiate(_S_Block1, new Vector3(0 - (151f / 2 + 10f) / 100, 0 - 151f / 2 / 100, 0), Quaternion.Euler(0,0,45));
        Obj6.transform.parent = parent.transform;
        GameObject Obj7 = (GameObject)Instantiate(_S_Block1, new Vector3(0 + (151f / 2 + 10f) / 100, 0 - 151f / 2 / 100, 0), Quaternion.Euler(0,0,45));
        Obj7.transform.parent = parent.transform;
        GameObject Obj8 = (GameObject)Instantiate(_S_Block1, new Vector3(0 - (151f / 2 + 10f) / 100, 0 + 151f / 2 / 100, 0), Quaternion.Euler(0,0,45));
        Obj8.transform.parent = parent.transform;
        GameObject Obj9 = (GameObject)Instantiate(_H_Block2, new Vector3(0 + (151f / 2 + 32f * 3 + 20f) / 100, 0, 0), Quaternion.Euler(0, 0, 90));
        Obj9.transform.parent = parent.transform;
        GameObject Obj10 = (GameObject)Instantiate(_H_Block2, new Vector3(0 - (151f / 2 + 32f * 3 + 20f) / 100, 0, 0), Quaternion.Euler(0, 0, 90));
        Obj10.transform.parent = parent.transform;
        GameObject Obj11 = (GameObject)Instantiate(_H_Block2, new Vector3(0, 0 + (151f / 2 + 32f * 3 + 20f) / 100, 0), Quaternion.identity);
        Obj11.transform.parent = parent.transform;
        GameObject Obj12 = (GameObject)Instantiate(_H_Block2, new Vector3(0, 0 - (151f / 2 + 32f * 3 + 20f) / 100, 0), Quaternion.identity);
        Obj12.transform.parent = parent.transform;
        /////////////////////////////////////////////////
        GameObject Obj13 = (GameObject)Instantiate(_S_Block1, new Vector3((-640f + 64f * 3 + 10f * 3) / 100, (360f - 60f) / 100, 0), Quaternion.identity);
        Obj13.transform.parent = parent.transform;
        GameObject Obj14 = (GameObject)Instantiate(T_S_Block1, new Vector3((-640f + 64f * 2 + 10f * 2) / 100, (360f - 160f) / 100, 0), Quaternion.identity);
        Obj14.transform.parent = parent.transform;
        GameObject Obj15 = (GameObject)Instantiate(_S_Block1, new Vector3((-640f + 64f * 1 + 10f * 1) / 100, (360f - 260f) / 100, 0), Quaternion.identity);
        Obj15.transform.parent = parent.transform;
        GameObject Obj16 = (GameObject)Instantiate(_S_Block1, new Vector3((-640f + 64f * 3 + 10f * 3) / 100, (-360f + 60f) / 100, 0), Quaternion.identity);
        Obj16.transform.parent = parent.transform;
        GameObject Obj17 = (GameObject)Instantiate(T_S_Block1, new Vector3((-640f + 64f * 2 + 10f * 2) / 100, (-360f + 160f) / 100, 0), Quaternion.identity);
        Obj17.transform.parent = parent.transform;
        GameObject Obj18 = (GameObject)Instantiate(_S_Block1, new Vector3((-640f + 64f * 1 + 10f * 1) / 100, (-360f + 260f) / 100, 0), Quaternion.identity);
        Obj18.transform.parent = parent.transform;
        GameObject Obj19 = (GameObject)Instantiate(B_S_Block3, new Vector3((-640f + 64f * 1 + 10f * 1) / 100, 0, 0), Quaternion.identity);
        Obj19.transform.parent = parent.transform;

        GameObject Obj20 = (GameObject)Instantiate(_S_Block1, new Vector3((640f - 64f * 3 + 10f * 3) / 100, (360f - 60f) / 100, 0), Quaternion.identity);
        Obj20.transform.parent = parent.transform;
        GameObject Obj21 = (GameObject)Instantiate(T_S_Block1, new Vector3((640f - 64f * 2 + 10f * 2) / 100, (360f - 160f) / 100, 0), Quaternion.identity);
        Obj21.transform.parent = parent.transform;                              
        GameObject Obj22 = (GameObject)Instantiate(_S_Block1, new Vector3((640f - 64f * 1 + 10f * 1) / 100, (360f - 260f) / 100, 0), Quaternion.identity);
        Obj22.transform.parent = parent.transform;                              
        GameObject Obj23 = (GameObject)Instantiate(_S_Block1, new Vector3((640f - 64f * 3 + 10f * 3) / 100, (-360f + 60f) / 100, 0), Quaternion.identity);
        Obj23.transform.parent = parent.transform;
        GameObject Obj24 = (GameObject)Instantiate(T_S_Block1, new Vector3((640f - 64f * 2 + 10f * 2) / 100, (-360f + 160f) / 100, 0), Quaternion.identity);
        Obj24.transform.parent = parent.transform;                              
        GameObject Obj25 = (GameObject)Instantiate(_S_Block1, new Vector3((640f - 64f * 1 + 10f * 1) / 100, (-360f + 260f) / 100, 0), Quaternion.identity);
        Obj25.transform.parent = parent.transform;
        GameObject Obj26 = (GameObject)Instantiate(B_S_Block3, new Vector3((640f - 64f * 1 + 10f * 1) / 100, 0, 0), Quaternion.identity);
        Obj26.transform.parent = parent.transform;

    }
	
}
