using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;  // プレイヤーのTransformを参照
    public Vector3 offset;    // カメラとプレイヤーの相対位置

    void Update()
    {
        // プレイヤーの位置にカメラを追従させる
        transform.position = player.position + offset;
    }
}
