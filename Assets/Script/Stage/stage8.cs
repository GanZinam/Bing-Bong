using UnityEngine;
using System.Collections;

public class stage8 : MonoBehaviour {

    public GameObject _S_Block1;        //일반정사 1
    public GameObject _S_Block2;        //일반정사 2

    public GameObject _O_Block1;        //일반팔각 1
    public GameObject _O_Block2;        //일반팔각 2

    public GameObject T_S_Block1;       //타임정사 1

    public int Block_num = 13;

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
        GameObject Obj3 = (GameObject)Instantiate(T_S_Block1, new Vector3(0, 0 + (151f / 2 + 42f) / 100, 0), Quaternion.identity);
        Obj3.transform.parent = parent.transform;
        GameObject Obj4 = (GameObject)Instantiate(T_S_Block1, new Vector3(0, 0 - (151f / 2 + 42f) / 100, 0), Quaternion.identity);
        Obj4.transform.parent = parent.transform;
        GameObject Obj5 = (GameObject)Instantiate(_S_Block2, new Vector3(0 + (151f / 2 + 42f) / 100, 0 + (151f / 2 + 42f) / 100, 0), Quaternion.identity);
        Obj5.transform.parent = parent.transform;
        GameObject Obj6 = (GameObject)Instantiate(_S_Block2, new Vector3(0 - (151f / 2 + 42f) / 100, 0 - (151f / 2 + 42f) / 100, 0), Quaternion.identity);
        Obj6.transform.parent = parent.transform;
        GameObject Obj7 = (GameObject)Instantiate(_S_Block2, new Vector3(0 + (151f / 2 + 42f) / 100, 0 - (151f / 2 + 42f) / 100, 0), Quaternion.identity);
        Obj7.transform.parent = parent.transform;
        GameObject Obj8 = (GameObject)Instantiate(_S_Block2, new Vector3(0 - (151f / 2 + 42f) / 100, 0 + (151f / 2 + 42f) / 100, 0), Quaternion.identity);
        Obj8.transform.parent = parent.transform;
        GameObject Obj9 = (GameObject)Instantiate(_S_Block2, new Vector3(0 + (151f / 2 + 3 * 42f) / 100, 0, 0), Quaternion.identity);
        Obj9.transform.parent = parent.transform;
        GameObject Obj10 = (GameObject)Instantiate(_S_Block2, new Vector3(0 - (151f / 2 + 3 * 42f) / 100, 0, 0), Quaternion.identity);
        Obj10.transform.parent = parent.transform;
        GameObject Obj11 = (GameObject)Instantiate(_S_Block2, new Vector3(0, 0 + (151f / 2 + 3 * 42f) / 100, 0), Quaternion.identity);
        Obj11.transform.parent = parent.transform;
        GameObject Obj12 = (GameObject)Instantiate(_S_Block2, new Vector3(0, 0 - (151f / 2 + 3 * 42f) / 100, 0), Quaternion.identity);
        Obj12.transform.parent = parent.transform;
    }
	
}
