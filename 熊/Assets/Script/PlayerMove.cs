using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;  // 移動速度
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Rigidbody2Dコンポーネントを取得
    }

    void Update()
    {
        // 入力を取得
        float moveX = Input.GetAxis("Horizontal");  // 左右移動
        float moveY = Input.GetAxis("Vertical");    // 上下移動

        // Rigidbody2Dを使って速度を設定
        rb.velocity = new Vector2(moveX, moveY) * moveSpeed;
    }
}
