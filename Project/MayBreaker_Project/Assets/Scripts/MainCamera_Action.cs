using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera_Action : MonoBehaviour
{
    public GameObject player;

    //ī�޶� ���� ��ġ
    public float offsetX = 0f;
    public float offsetY = 4.3f;
    public float offsetZ = -4.7f;
    public float followSpeed = 4.2f;

    //ī�޶� �̵� �� ��ġ
    Vector3 cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        //ĳ���� �̵��� ��ŭ ī�޶� �̵� �� ����
        cameraPosition.x = player.transform.position.x + offsetX;
        cameraPosition.y = player.transform.position.y + offsetY;
        cameraPosition.z = player.transform.position.z + offsetZ;

        //ī�޶� �̵�
        transform.position = cameraPosition;

        //ī�޶� ������ �̵�
        //transform.position = Vector3.Lerp(transform.position, cameraPosition, followSpeed * Time.deltaTime);
    }
}
