using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrPlayerLixo : MonoBehaviour
{
     public TipoLixo tipoLixo = TipoLixo.Nenhum;
    public Image imgLixo;
    public bool isCollected = false;

     public void ResetLixo()
    {
        tipoLixo = TipoLixo.Nenhum;
        if (imgLixo != null)
        {
            imgLixo.enabled = false;
        }
        isCollected = false;
    }
}
