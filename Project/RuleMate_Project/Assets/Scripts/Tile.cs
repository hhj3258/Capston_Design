using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private Animation ani;
    private bool isTrue = true;

    [SerializeField]
    private string cname;

    // Start is called before the first frame update
    void Start()
    {
        ani = this.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�´� Ÿ������ Ȯ��
    protected void CheckObj(string name)
    {
        Debug.Log("üũ" + name +" / " + cname + " / " );
        if (true)
        {
            Flip();
        }
    }

    //������ �ִϸ��̼� �÷���
    protected void Flip()
    {
        Debug.Log("ȸ��");
        ani.Play();
    }
}
