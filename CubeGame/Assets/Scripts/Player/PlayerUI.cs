using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _Olhos;
    bool _RodarPosicaoDomause;
    void Update()
    {

        Vector2 _A = Input.mousePosition;

        float[] Posicoes = new float[2];// X Y

        Posicoes[0] = _A.x;
        Posicoes[1] = _A.y;

        _RodarPosicaoDomause = true;
        if (Input.GetKeyDown(KeyCode.T))
            Debug.Log(_A);
        if (Posicoes[0] >= 973)
        {
            _RodarPosicaoDomause = false;
            _Olhos.transform.position = new Vector2(973,Posicoes[1]);
            if(Posicoes[1] >= 673)
            {
                _Olhos.transform.position = new Vector2(973,673);
            }
            if(Posicoes[1] <= 328)
            {
                _Olhos.transform.position = new Vector2(973, 328);
            }
        }
        if (Posicoes[0] <= 746)
        {
            _RodarPosicaoDomause = false;
            _Olhos.transform.position = new Vector2(746, Posicoes[1]);
            if (Posicoes[1] >= 673)
            {
                _Olhos.transform.position = new Vector2(746, 673);
            }
            if (Posicoes[1] <= 328)
            {
                _Olhos.transform.position = new Vector2(746, 328);
            }
        }
        if (Posicoes[1] >= 673)
        {
            _RodarPosicaoDomause = false;
            _Olhos.transform.position = new Vector2(Posicoes[0], 673);
            if (Posicoes[0] >= 973)
            {
                _Olhos.transform.position = new Vector2(973, 673);
            }
            if (Posicoes[0] <= 746)
            {
                _Olhos.transform.position = new Vector2(746, 673);
            }
        }
        if (Posicoes[1] <= 328)
        {
            _RodarPosicaoDomause = false;
            _Olhos.transform.position = new Vector2(Posicoes[0], 328);
            if (Posicoes[0] >= 973)
            {
                _Olhos.transform.position = new Vector2(973, 328);
            }
            if (Posicoes[0] <= 746)
            {
                _Olhos.transform.position = new Vector2(746, 328);
            }
        }
        if (_RodarPosicaoDomause)
        {
            _Olhos.transform.position = _A;
        }

    }
}
