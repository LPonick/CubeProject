using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class TesteCena : MonoBehaviour
{
    enum BotaoQueFoiApertado
    {
        Nulo,
        Vermelho,
        Branco,
        Azul
    };

    private SpriteRenderer _Sprite;
    [SerializeField]
    private BotaoQueFoiApertado _BotaoApertado;

    [SerializeField]
    private int _Pontos;

    public string[] _Controles = new string[3];//vermelho,branco,azul
    
        
    void Start()
    {   
        _Sprite = GetComponent<SpriteRenderer>();
        TesteDeBotoes();
    }

    void Update()
    {

        
        TroncaCor();
    }

    private void TesteDeBotoes()
    {
        for (int i = 0; i < _Controles.Length; i++)
        {
            if (_Controles[i] == "")
            {
                if (i == 0)
                {
                    _Controles[0] = "a";
                }
                if (i == 1)
                {
                    _Controles[1] = "s";
                }
                if (i == 2)
                {
                    _Controles[2] = "d";
                }
            }//If
        }//For
    }//Metodo


    private void TroncaCor()
    {
        if (Input.GetKeyDown(_Controles[0]))
        {
            if(_BotaoApertado != BotaoQueFoiApertado.Vermelho)
            {
                _Sprite.color = Color.red;
                _Pontos++;
                _BotaoApertado = BotaoQueFoiApertado.Vermelho;
            }
        }
        if (Input.GetKeyDown(_Controles[1]))
        {
            if (_BotaoApertado != BotaoQueFoiApertado.Branco)
            {
                _Pontos++;
                _BotaoApertado = BotaoQueFoiApertado.Branco;
                _Sprite.color = Color.white;
            }
        }
        if (Input.GetKeyDown(_Controles[2]))
        {
             if (_BotaoApertado != BotaoQueFoiApertado.Azul)
             {
                 _Pontos++;
                 _BotaoApertado = BotaoQueFoiApertado.Azul;
                 _Sprite.color = Color.blue;
             }
        }
    }//Fim do metodo

}//Final do codigo
