using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Enemy�̗̑͗p�ϐ�
    private int enemyHp;

    // Start is called before the first frame update
    void Start()
    {
        //�������ɑ̗͂��w�肵�Ă���
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //�G�̃��[���h���W���擾
        Vector3 pos = transform.position;

        //�����̗͂�0�ȉ��ɂȂ�����
        if (enemyHp <= 0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);
        }

        if (pos.z <= -20)
        {
            Destroy(this.gameObject);
        }
    }

    public void Damage()
    {
        //Enemy�̗̑͂�1���炷
        enemyHp -= 1;
    }
}
