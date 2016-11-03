using UnityEngine;
using System.Collections;

public class stage5 : MonoBehaviour {

    public GameObject _S_Block1;        //일반정사 1
    public GameObject _S_Block2;        //일반정사 2

    public GameObject B_S_Block1;       //폭발정사 1
    public GameObject B_S_Block2;       //폭발정사 2
    public GameObject B_S_Block3;       //폭발정사 3

    public int Block_num = 44;

    GameObject parent;

    // Use this for initialization
    void Start()
    {
        parent = GameObject.Find("Block");

        //가운데///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        GameObject Obj = (GameObject)Instantiate(_S_Block2, new Vector3(0, 0, 0), Quaternion.identity);
        Obj.transform.parent = parent.transform;
        GameObject Obj1 = (GameObject)Instantiate(_S_Block1, new Vector3(0 + (64f + 10f) / 100, 0, 0), Quaternion.identity);
        Obj1.transform.parent = parent.transform;
        GameObject Obj2 = (GameObject)Instantiate(_S_Block1, new Vector3(0 - (64f + 10f) / 100, 0, 0), Quaternion.identity);
        Obj2.transform.parent = parent.transform;
        GameObject Obj3 = (GameObject)Instantiate(_S_Block1, new Vector3(0, 0 + (64f + 10f) / 100, 0), Quaternion.identity);
        Obj3.transform.parent = parent.transform;
        GameObject Obj4 = (GameObject)Instantiate(_S_Block1, new Vector3(0, 0 - (64f + 10f) / 100, 0), Quaternion.identity);
        Obj4.transform.parent = parent.transform;
        GameObject Obj5 = (GameObject)Instantiate(_S_Block1, new Vector3(0 - 2 * ((64f + 10f) / 100), 0 - (64f + 10f) / 100, 0), Quaternion.identity);
        Obj5.transform.parent = parent.transform;
        GameObject _Obj5 = (GameObject)Instantiate(_S_Block1, new Vector3(0 + 2 * ((64f + 10f) / 100), 0 - (64f + 10f) / 100, 0), Quaternion.identity);
        _Obj5.transform.parent = parent.transform;
        GameObject Obj6 = (GameObject)Instantiate(_S_Block1, new Vector3(0 - 2 * ((64f + 10f) / 100), 0 + (64f + 10f) / 100, 0), Quaternion.identity);
        Obj6.transform.parent = parent.transform;
        GameObject _Obj6 = (GameObject)Instantiate(_S_Block1, new Vector3(0 + 2 * ((64f + 10f) / 100), 0 + (64f + 10f) / 100, 0), Quaternion.identity);
        _Obj6.transform.parent = parent.transform;
        GameObject Obj7 = (GameObject)Instantiate(_S_Block2, new Vector3(0 + 2 * ((64f + 10f) / 100), 0, 0), Quaternion.identity);
        Obj7.transform.parent = parent.transform;
        GameObject Obj8 = (GameObject)Instantiate(_S_Block2, new Vector3(0 - 2 * ((64f + 10f) / 100), 0, 0), Quaternion.identity);
        Obj8.transform.parent = parent.transform;
        GameObject Obj9 = (GameObject)Instantiate(_S_Block2, new Vector3(0 - ((64f + 10f) / 100), 0 - ((64f + 10f) / 100), 0), Quaternion.identity);
        Obj9.transform.parent = parent.transform;
        GameObject Obj10 = (GameObject)Instantiate(_S_Block2, new Vector3(0 + ((64f + 10f) / 100), 0 + ((64f + 10f) / 100), 0), Quaternion.identity);
        Obj10.transform.parent = parent.transform;
        GameObject Obj11 = (GameObject)Instantiate(_S_Block2, new Vector3(0 - ((64f + 10f) / 100), 0 + ((64f + 10f) / 100), 0), Quaternion.identity);
        Obj11.transform.parent = parent.transform;
        GameObject Obj12 = (GameObject)Instantiate(_S_Block2, new Vector3(0 + ((64f + 10f) / 100), 0 - ((64f + 10f) / 100), 0), Quaternion.identity);
        Obj12.transform.parent = parent.transform;
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //모서리///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        GameObject Obj13 = (GameObject)Instantiate(_S_Block1, new Vector3((-640f + (64f / 2 + 10f)) / 100, 320f / 100, 0), Quaternion.identity);
        Obj13.transform.parent = parent.transform;
        GameObject Obj14 = (GameObject)Instantiate(_S_Block2, new Vector3((-640f + (64f + 32f + 2 * 10f)) / 100, 320f / 100, 0), Quaternion.identity);
        Obj14.transform.parent = parent.transform;
        GameObject Obj15 = (GameObject)Instantiate(_S_Block2, new Vector3((-640f + (64 / 2 + 10f)) / 100, (320f - 64f - 10f) / 100, 0), Quaternion.identity);
        Obj15.transform.parent = parent.transform;
        GameObject Obj16 = (GameObject)Instantiate(_S_Block1, new Vector3((-640f + (64f / 2 + 10f)) / 100, -320f / 100, 0), Quaternion.identity);
        Obj16.transform.parent = parent.transform;
        GameObject Obj17 = (GameObject)Instantiate(_S_Block2, new Vector3((-640f + (64 / 2 + 10f)) / 100, (-320f + 64f + 10f) / 100, 0), Quaternion.identity);
        Obj17.transform.parent = parent.transform;
        GameObject Obj18 = (GameObject)Instantiate(_S_Block2, new Vector3((-640f + (64f + 32f + 2 * 10f)) / 100, -320f / 100, 0), Quaternion.identity);
        Obj18.transform.parent = parent.transform;

        GameObject Obj19 = (GameObject)Instantiate(_S_Block2, new Vector3((-640f + (64f *2.5f + 30f)) / 100, 320f / 100, 0), Quaternion.identity);
        Obj19.transform.parent = parent.transform;
        GameObject Obj20 = (GameObject)Instantiate(B_S_Block3, new Vector3((-640f + (64f + 32f + 2 * 10f)) / 100, (320f - 74f) / 100, 0), Quaternion.identity);
        Obj20.transform.parent = parent.transform;
        GameObject Obj21 = (GameObject)Instantiate(_S_Block2, new Vector3((-640f + (64 / 2 + 10f)) / 100, (320f - 74f * 2) / 100, 0), Quaternion.identity);
        Obj21.transform.parent = parent.transform;
        GameObject Obj22 = (GameObject)Instantiate(_S_Block2, new Vector3((-640f + (64f * 2.5f + 30f)) / 100, -320f / 100, 0), Quaternion.identity);
        Obj22.transform.parent = parent.transform;
        GameObject Obj23 = (GameObject)Instantiate(B_S_Block3, new Vector3((-640f + (64f + 32f + 2 * 10f)) / 100, (-320f + 74f) / 100, 0), Quaternion.identity);
        Obj23.transform.parent = parent.transform;
        GameObject Obj24 = (GameObject)Instantiate(_S_Block2, new Vector3((-640f + (64 / 2 + 10f)) / 100, (-320f + 74 * 2) / 100, 0), Quaternion.identity);
        Obj24.transform.parent = parent.transform;

        GameObject Obj25 = (GameObject)Instantiate(_S_Block1, new Vector3((640f - (64f / 2 + 10f)) / 100, 320f / 100, 0), Quaternion.identity);
        Obj25.transform.parent = parent.transform;
        GameObject Obj26 = (GameObject)Instantiate(_S_Block2, new Vector3((640f - (64f + 32f + 2 * 10f)) / 100, 320f / 100, 0), Quaternion.identity);
        Obj26.transform.parent = parent.transform;
        GameObject Obj27 = (GameObject)Instantiate(_S_Block2, new Vector3((640f - (64 / 2 + 10f)) / 100, (320f - 64f - 10f) / 100, 0), Quaternion.identity);
        Obj27.transform.parent = parent.transform;
        GameObject Obj28 = (GameObject)Instantiate(_S_Block1, new Vector3((640f - (64f / 2 + 10f)) / 100, -320f / 100, 0), Quaternion.identity);
        Obj28.transform.parent = parent.transform;
        GameObject Obj29 = (GameObject)Instantiate(_S_Block2, new Vector3((640f - (64 / 2 + 10f)) / 100, (-320f + 64f + 10f) / 100, 0), Quaternion.identity);
        Obj29.transform.parent = parent.transform;
        GameObject Obj30 = (GameObject)Instantiate(_S_Block2, new Vector3((640f - (64f + 32f + 2 * 10f)) / 100, -320f / 100, 0), Quaternion.identity);
        Obj30.transform.parent = parent.transform;

        GameObject Obj31 = (GameObject)Instantiate(_S_Block2, new Vector3((640f - (64f * 2.5f + 30f)) / 100, 320f / 100, 0), Quaternion.identity);
        Obj31.transform.parent = parent.transform;
        GameObject Obj32 = (GameObject)Instantiate(B_S_Block3, new Vector3((640f - (64f + 32f + 2 * 10f)) / 100, (320f - 74f) / 100, 0), Quaternion.identity);
        Obj32.transform.parent = parent.transform;
        GameObject Obj33 = (GameObject)Instantiate(_S_Block2, new Vector3((640f - (64 / 2 + 10f)) / 100, (320f - 74f * 2) / 100, 0), Quaternion.identity);
        Obj33.transform.parent = parent.transform;
        GameObject Obj34 = (GameObject)Instantiate(_S_Block2, new Vector3((640f - (64f * 2.5f + 30f)) / 100, -320f / 100, 0), Quaternion.identity);
        Obj34.transform.parent = parent.transform;
        GameObject Obj35 = (GameObject)Instantiate(B_S_Block3, new Vector3((640f - (64f + 32f + 2 * 10f)) / 100, (-320f + 74f) / 100, 0), Quaternion.identity);
        Obj35.transform.parent = parent.transform;
        GameObject Obj36 = (GameObject)Instantiate(_S_Block2, new Vector3((640f - (64 / 2 + 10f)) / 100, (-320f + 74 * 2) / 100, 0), Quaternion.identity);
        Obj36.transform.parent = parent.transform;
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
	
}
