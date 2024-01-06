using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatAndRotation : MonoBehaviour
{
    [SerializeField] private float RotateSpeed = 1f;
    public float floatSpeed = 1.0f; // 浮動速度
    public float floatMagnitude = 0.5f; // 浮動幅度
    private float startY; // 初始 Y 軸位置

    private void Start()
    {
        startY = transform.position.y; // 紀錄初始 Y 軸位置
    }
    private void Update()
    {
        transform.Rotate(Vector3.up, RotateSpeed * Time.deltaTime);
        // 使用 Sin 函數來計算浮動的位移
        float yOffset = Mathf.Sin(Time.time * floatSpeed) * floatMagnitude;

        // 更新物體的位置
        transform.position = new Vector3(transform.position.x, startY + yOffset, transform.position.z);
    }
}
