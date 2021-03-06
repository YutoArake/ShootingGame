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
        //もし体力が0以下になったら
        if (HP <= 0)
        {
            //自分で消える
            Destroy(this.gameObject);
        }
        
    }

    public void Damage()
    {
        //Enemyの体力を1減らす
        HP -= 1;
        gameManager.HpCount();
    }

}
