using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    //�G�̐��𐔂���p�̕ϐ�
    public GameObject[] enemy;
    public GameObject boss;

    public GameObject player;

    //�p�l����o�^����
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
        //�p�l�����B��
        clearPanel.SetActive(false);
        overPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�V�[���ɑ��݂��Ă���Enemy�^�O�������Ă���I�u�W�F�N�g
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        boss = GameObject.FindGameObjectWithTag("Boss");
        player = GameObject.FindGameObjectWithTag("Player");

        //�V�[����1�C��Enemy�����Ȃ��Ȃ�����
        if (enemy.Length == 0 && boss == null)
        {
            //�p�l����\��������
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
