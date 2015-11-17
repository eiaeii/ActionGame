using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

    public SkinnedMeshRenderer headRenderer;
    public SkinnedMeshRenderer handRenderre;
    public SkinnedMeshRenderer[] bodyArray;

    public Mesh[] headMeshArray;
    private int headMeshIndex = 0;
    public Mesh[] handMeshArray;
    private int handMeshIndex = 0;

	public void OnHeadMeshNext()
    {
        headMeshIndex++;
        if (headMeshIndex >= headMeshArray.Length)
        {
            headMeshIndex = 0;
        }
        headRenderer.sharedMesh = headMeshArray[headMeshIndex];
    }

    public void OnHandMeshNext()
    {
        handMeshIndex++;
        if (handMeshIndex >= handMeshArray.Length)
        {
            handMeshIndex = 0;
        }
        handRenderre.sharedMesh = handMeshArray[handMeshIndex];
    }

    public void OnChangeColor(Color color)
    {
        foreach(SkinnedMeshRenderer renderer in bodyArray)
        {
            renderer.material.color = color;
        }
    }

    public void OnChangeColorBlue()
    {
        OnChangeColor(Color.blue);
    }

    public void OnChangeColorCyan()
    {
        OnChangeColor(Color.cyan);
    }

    public void OnChangeColorGreen()
    {
        OnChangeColor(Color.green);
    }

    public void OnChangeColorPurple()
    {
        OnChangeColor(new Color(0.5f, 0, 0.5f, 1));
    }

    public void OnChangeColorRed()
    {
        OnChangeColor(Color.red);
    }

    public void OnPlay()
    {

    }
}
