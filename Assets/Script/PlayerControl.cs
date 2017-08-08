using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

    [Header( "水平方向" )]
    public float moveX;

    [Header( "垂直方向" )]
    public float moveY;

    [Header("推力")]
    public float push;

    Rigidbody2D rb2D;//剛體  施力用

    [Header("分數文字UI")]
    public Text countText;
    [Header("過關文字UI")]
    public Text winText;

    int score; //分數

    // Use this for initialization
    void Start () {

        rb2D = GetComponent<Rigidbody2D>();
        //rb2D = 取得組件<鋼體2D> ();

        winText.text = "";
        setScoreText();

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        moveX = Input.GetAxis("Horizontal");
        //水平移動 = 輸入.取得軸向("水平");

        moveY = Input.GetAxis("Vertical");
        //水平移動 = 輸入.取得軸向("垂直");

        Vector2 movement = new Vector2(moveX, moveY);

        rb2D.AddForce(push * movement);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(name + "觸發了" + other.name);

        if (other.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
        }

        score = score + 1;
        setScoreText();

    }

    void setScoreText() {

        countText.text = "目前分數:" + score.ToString();

        if (score >= 12)
            winText.text = "你贏了";

    }

}
