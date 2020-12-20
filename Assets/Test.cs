﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{

    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力

    private int mp = 3;   //魔法力


    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic(int use_mp)
    {

        //mpが0より上の場合のみmpを消費するようにする。　mpが0以下の場合この代入は行われない。
        if (mp > 0)
        {
            this.mp -= use_mp;
        }

        if (this.mp >= 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else if (this.mp < 5 && this.mp > 0) { 
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else{
            Debug.Log("MPが足りないため魔法が使えない。");
        }




    }


}




public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {


        //配列の宣言
        int[] array = { 11, 22, 33, 44, 55 };

        //配列の順次表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);

        }

        //配列の逆順次表示
        for (int i = array.Length-1; 0 <= i; i--)
        {
            Debug.Log(array[i]);

        }


        //Class実行
        //Instance化
        Boss battle = new Boss();

        //Class 関数　各種実行
        battle.Attack();
        battle.Defence(3);

        //回数10回をfor文で実現
        for (int i =0; i < 11; i++)
        {
            battle.Magic(5);

        }

  

        battle.Attack();
        battle.Defence(3);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
