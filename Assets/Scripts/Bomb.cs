using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    //発生させるパーティクルのプレハブ
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
        //キーボードのBキーが押されたら
        if (Input.GetKeyDown(KeyCode.B) && BombNum > 0)
        {
            //タグが同じオブジェクトをすべて取得する
            GameObject[] enemyBulletObjects = GameObject.FindGameObjectsWithTag("EnemyBullet");

            //上で取得した全てのオブジェクトを消滅させる
            for (int i = 0; i < enemyBulletObjects.Length; i++)
            {
                Destroy(enemyBulletObjects[i]);
            }

            //パーティクルを持ったオブジェクトを生成する
            Instantiate(particle, Vector3.zero, Quaternion.identity);

            gameManager.BombCount();

            BombNum--;
        }
    }
}
