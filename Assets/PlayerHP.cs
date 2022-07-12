using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public GManager gameManager;
    private int HP;

    // Start is called before the first frame update
    void Start()
    {
        HP = 5;
        GameObject managerObject = GameObject.Find("GameManager");
        gameManager = managerObject.GetComponent<GManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //�����̗͂�0�ȉ��ɂȂ�����
        if (HP <= 0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);
        }
        
    }

    public void Damage()
    {
        //Enemy�̗̑͂�1���炷
        HP -= 1;
        gameManager.HpCount();
    }

}
