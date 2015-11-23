using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// 摇杆
/// </summary>
public class JoystackControl : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector3 originPosition;//起点坐标
    Vector3 newPosition;
    public float Radius = 40; //滚动的最大半径
    public static float horizontal = 0;
    public static float vertical = 0;
    private Vector3 dir = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        originPosition = transform.position;//记录原点位置
    }

    // Update is called once per frame
    void Update()
    {
        vertical = (transform.position.y - originPosition.y) / Radius;
        horizontal = (transform.position.x - originPosition.x) / Radius;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = originPosition; //归位到原点
    }

    
    public void OnDrag(PointerEventData eventData)
    {

        dir = (Input.mousePosition - originPosition).normalized;

        transform.position = Input.mousePosition; //设置当前摇杆位置

        //当超过了外面的圆圈
        if (Vector3.Distance(Input.mousePosition, originPosition) > Radius)
            transform.position = originPosition + dir * Radius;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }
}