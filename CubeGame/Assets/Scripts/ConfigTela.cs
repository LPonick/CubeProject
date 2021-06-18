using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfigTela : MonoBehaviour
{
    private int[] _IResolucaoTelax = new int[2];
    private int[] _IResolucaoTelay = new int[2];    
    private int[,] _Resolucoes = new int[3, 2] { {1920,1080},{1600,900},{1024,768} };
    private bool _FullScream = true;
    public void EstadoDoBotao(bool EstadoDoBotao)
    {
        _FullScream = EstadoDoBotao;
        TrocaDaResolucao();
        Debug.Log(EstadoDoBotao);
    }

    public void EstadoDaResolução(int Resolucao)
    {
        switch (Resolucao)
        {
            case 0:
                _IResolucaoTelax[0] = 0;
                _IResolucaoTelay[0] = 0;

                _IResolucaoTelax[1] = 0;
                _IResolucaoTelay[1] = 1;

                break;
                    case 1:
                    _IResolucaoTelax[0] = 1;
                    _IResolucaoTelay[0] = 0;

                    _IResolucaoTelax[1] = 1;
                    _IResolucaoTelay[1] = 1;
                break;
                        case 2:
                        _IResolucaoTelax[0] = 2;
                        _IResolucaoTelay[0] = 0;

                        _IResolucaoTelax[1] = 2;
                        _IResolucaoTelay[1] = 1;
                break;
        }

        TrocaDaResolucao();
    }
    public void TrocaGrafico(int ValorEscolido)
    {
        QualitySettings.SetQualityLevel(ValorEscolido);
        Debug.Log(ValorEscolido);
    }
    public void TrocaDaResolucao()
    {
        Screen.SetResolution(_Resolucoes[_IResolucaoTelax[0],_IResolucaoTelay[0]],_Resolucoes[_IResolucaoTelax[1],_IResolucaoTelay[1]],_FullScream);
    }

}
