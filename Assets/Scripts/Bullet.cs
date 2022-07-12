using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //�e�̑��x
    public float bulletSpeed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�e�̃��[���h���W���擾
        Vector3 pos = transform.position;

        //��ɂ܂��������
        pos.z += bulletSpeed;

        //�e�̈ړ�
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        //��苗���i�񂾂���ł���
        if(pos.z >= 20)
        {
            Destroy(this.gameObject);
        }
    }

    //�����蔻��p�֐�
    void OnTriggerEnter(Collider other)
    {
        //�������������I�u�W�F�N�g�̃^�O��Enemy��������
        if(other.gameObject.tag == "Enemy")
        {
            //���������I�u�W�F�N�g��Enemy�X�N���v�g���Ăяo����Damage�֐������s������
            other.GetComponent<Enemy>().Damage();
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Boss")
        {
            //���������I�u�W�F�N�g��Enemy�X�N���v�g���Ăяo����Damage�֐������s������
            other.GetComponent<Boss>().Damage();
            Destroy(this.gameObject);
        }
    }
}
