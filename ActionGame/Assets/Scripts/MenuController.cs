using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

    //public static MenuController _Instance;
    public SkinnedMeshRenderer headRenderer;
    public SkinnedMeshRenderer handRenderre;
    public SkinnedMeshRenderer[] bodyArray;

    public Mesh[] headMeshArray;
    private int headMeshIndex = 0;
    public Mesh[] handMeshArray;
    private int handMeshIndex = 0;

    public Color[] colorArray;
    private int colorIndex = 0;
    
    void Start()
    {
        colorArray = new Color[]{
            Color.blue, Color.cyan, Color.green, new Color(0.5f, 0, 0.5f, 1), Color.red
        };

        if (PlayerPrefs.HasKey("HeadMeshIndex"))
        {
            headMeshIndex = PlayerPrefs.GetInt("HeadMeshIndex");
        }
        else
        {
            headMeshIndex = 0;
        }
        SetHeadMesh();

        if (PlayerPrefs.HasKey("HandMeshIndex"))
        {
            handMeshIndex = PlayerPrefs.GetInt("HandMeshIndex");
        }
        else
        {
            handMeshIndex = 0;
        }
        SetHandMesh();

        if (PlayerPrefs.HasKey("ColorIndex"))
        {
            colorIndex = PlayerPrefs.GetInt("ColorIndex");
        }
        else
        {
            colorIndex = 0;
        }
        OnChangeColor(colorArray[colorIndex]);

        //DontDestroyOnLoad(this.gameObject);
    } 

    void Awake()
    {
        //_Instance = this;
    }

	public void OnHeadMeshNext()
    {
        headMeshIndex++;
        if (headMeshIndex >= headMeshArray.Length)
        {
            headMeshIndex = 0;
        }
        headRenderer.sharedMesh = headMeshArray[headMeshIndex];
        Save();
    }

    public void OnHandMeshNext()
    {
        handMeshIndex++;
        if (handMeshIndex >= handMeshArray.Length)
        {
            handMeshIndex = 0;
        }
        handRenderre.sharedMesh = handMeshArray[handMeshIndex];
        Save();
    }

    public void OnChangeColor(Color color)
    {
        foreach(SkinnedMeshRenderer renderer in bodyArray)
        {
            renderer.material.color = color;
        }
        Save();
    }

    public void OnChangeColorBlue()
    {
        colorIndex = 0;
        OnChangeColor(colorArray[0]);
    }

    public void OnChangeColorCyan()
    {
        colorIndex = 1;
        OnChangeColor(colorArray[1]);
    }

    public void OnChangeColorGreen()
    {
        colorIndex = 2;
        OnChangeColor(colorArray[2]);
    }

    public void OnChangeColorPurple()
    {
        colorIndex = 3;
        OnChangeColor(colorArray[3]);
    }

    public void OnChangeColorRed()
    {
        colorIndex = 4;
        OnChangeColor(colorArray[4]);
    }

    public void OnPlay()
    {
        Application.LoadLevel("Level1");
    }

    void Save()
    {
        PlayerPrefs.SetInt("ColorIndex", colorIndex);
        PlayerPrefs.SetInt("HeadMeshIndex", headMeshIndex);
        PlayerPrefs.SetInt("HandMeshIndex", handMeshIndex);
        PlayerPrefs.Save();
    }

    void SetHeadMesh()
    {
        headRenderer.sharedMesh = headMeshArray[headMeshIndex];
    }

    void SetHandMesh()
    {
        handRenderre.sharedMesh = handMeshArray[handMeshIndex];
    }
}
