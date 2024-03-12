using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneMaterialManager : MonoBehaviour
{
    public Material planeMaterial;

    public Button[] planeTexButtons;

    private void Awake()
    {
        foreach (var b in planeTexButtons)
        {
            Texture texture = b.transform.Find("Mask/RawImage").GetComponent<RawImage>().texture;
            b.onClick.AddListener(()=>OnClickButton(texture));
        }
    }


    void OnClickButton(Texture tex)
    {
        planeMaterial.mainTexture = tex;
    }
}
