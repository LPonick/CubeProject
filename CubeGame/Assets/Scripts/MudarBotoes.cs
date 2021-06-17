using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarBotoes : MonoBehaviour
{
    [SerializeField]
    private string SenaJogo;
    [SerializeField]
    TesteCena _PrefabPlayer;//vai editar o prefab
    [SerializeField]
    TextMeshProUGUI[] Botoes;//bote quantos botoes sao atraz do inspector

    [SerializeField]
    TesteCena _Inputs;//vai receber o inputs do jogador 

    private void Start()
    {

    }
    private void Update()
    {
        for(int i = 0;i<Botoes.Length;i++)
        {
            Botoes[i].text = _Inputs._Controles[i].ToUpper();
        }
    }
    public void ReceberInputs()
    {
        for(int i = 0;i<_PrefabPlayer._Controles.Length;i++)
        {
            _PrefabPlayer._Controles[i] = _Inputs._Controles[i];
        }
    }
    public void IniciarJogo()
    {
        SceneManager.LoadScene(SenaJogo);
    }

}
