using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    //敵の数を数える用の変数
    public GameObject[] enemy;
    public GameObject boss;

    public GameObject player;

    //パネルを登録する
    public GameObject clearPanel;
    public GameObject overPanel;

    public Text bombText;
    public Text hpText;

    private int bombCount = 5;
    private int hp = 5;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        //パネルを隠す
        clearPanel.SetActive(false);
        overPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //シーンに存在しているEnemyタグを持っているオブジェクト
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        boss = GameObject.FindGameObjectWithTag("Boss");
        player = GameObject.FindGameObjectWithTag("Player");

        //シーンに1匹もEnemyがいなくなったら
        if (enemy.Length == 0 && boss == null)
        {
            //パネルを表示させる
            clearPanel.SetActive(true);
        }

        if (player == null)
        {
            overPanel.SetActive(true);
        }
    }

    public void BombCount()
    {
        bombCount--;
        Debug.Log("Bomb : " + bombCount.ToString());
        bombText.text = "Bomb : " + bombCount.ToString();
    }

    public void HpCount()
    {
        hp--;
        Debug.Log("HP : " + hp.ToString());
        hpText.text = "HP : " + hp.ToString();
    }
}
