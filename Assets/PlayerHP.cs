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
        //‚à‚µ‘Ì—Í‚ª0ˆÈ‰º‚É‚È‚Á‚½‚ç
        if (HP <= 0)
        {
            //Ž©•ª‚ÅÁ‚¦‚é
            Destroy(this.gameObject);
        }
        
    }

    public void Damage()
    {
        //Enemy‚Ì‘Ì—Í‚ð1Œ¸‚ç‚·
        HP -= 1;
        gameManager.HpCount();
    }

}
