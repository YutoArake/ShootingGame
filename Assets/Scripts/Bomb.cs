using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    //����������p�[�e�B�N���̃v���n�u
    public GameObject particle;

    public GManager gameManager;

    public int BombNum;

    // Start is called before the first frame update
    void Start()
    {
        BombNum = 5;
        GameObject managerObject = GameObject.Find("GameManager");
        gameManager = managerObject.GetComponent<GManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //�L�[�{�[�h��B�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.B) && BombNum > 0)
        {
            //�^�O�������I�u�W�F�N�g�����ׂĎ擾����
            GameObject[] enemyBulletObjects = GameObject.FindGameObjectsWithTag("EnemyBullet");

            //��Ŏ擾�����S�ẴI�u�W�F�N�g�����ł�����
            for (int i = 0; i < enemyBulletObjects.Length; i++)
            {
                Destroy(enemyBulletObjects[i]);
            }

            //�p�[�e�B�N�����������I�u�W�F�N�g�𐶐�����
            Instantiate(particle, Vector3.zero, Quaternion.identity);

            gameManager.BombCount();

            BombNum--;
        }
    }
}
