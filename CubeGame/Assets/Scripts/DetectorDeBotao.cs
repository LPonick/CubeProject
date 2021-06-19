using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeBotao : MonoBehaviour
{
    private string _CorApertada;
    private bool executar;
    

    [SerializeField]
    PlayerController _Mudar;
    void Start()
    {
        
    }

    void Update()
    {
        executar = true;
        string ValorApertado = Input.inputString.ToLower();
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Desabilitador();
        }
        if(ValorApertado.Length != 0)
        {
            for (int i = 0; i < _Mudar._Controles.Length; i++)
            {
                if (ValorApertado == _Mudar._Controles[i])
                {
                    executar = false;
                    Desabilitador();
                }
            }
            if (ValorApertado.Length == 1 && executar)
            {
                switch (_CorApertada)
                {
                    case "Vermelha":
                        _Mudar._Controles[0] = ValorApertado;
                        Desabilitador();
                    break;
                        case "Branca":
                            _Mudar._Controles[1] = ValorApertado;
                            Desabilitador();
                        break;
                            case "Azul":
                                _Mudar._Controles[2] = ValorApertado;
                                 Desabilitador();
                            break;
                }

            }
            else
            {
                Desabilitador();
            }
        }//primeiro if

    }//update

    public void BotaoApertado(string Cor)
    {
        _CorApertada = Cor;   
    }
    private void Desabilitador()
    {
        gameObject.SetActive(false);
    }
}
