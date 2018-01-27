using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	int mp = 53;

	public void Magic (){
		mp = mp-5;

		if (mp >= 0){
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		}

		else {
			Debug.Log ("MPが足りないため魔法が使えない");
		}
	}
}
	

public class Test : MonoBehaviour {

	//Use this for initialization
	void Start () {

		//Magic関数を呼び出して、魔法を使ってください
		//Magic関数を10回使った後に、更にMagic関数を呼び出すと、mpが足りないメッセージが表示されることを確認してください
		Boss TestBoss = new Boss();

		for (int i = 0; i < 10; i++) {
			TestBoss.Magic();
		}

		TestBoss.Magic();

		//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
		int[] array = {2,4,6,8,10};

		//配列の各要素の値を順番に表示してください
		Debug.Log (array [0]);
		Debug.Log (array [1]);
		Debug.Log (array [2]);
		Debug.Log (array [3]);
		Debug.Log (array [4]);

		//for文を使い、配列の各要素の値を逆順に表示してください
		for (int a = 4; a >= 0; a--) {
			Debug.Log(array[a]);
		}
		/*
		Array.Reverse (array);
		for (int j = 0; j < array.Length; j++) {
			Debug.Log(array[j]);
		}
		*/
	}

	// Update is called once per frame
	void Update () {
		
	}
}
	