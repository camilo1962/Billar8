using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RevolutionGames.Game
{
    public class GameRules : MonoBehaviour
    {
        public GameManager gameManager;
        private void Start()
        {
            
        }
        public int ValidateCurrentStrike()
        {
            return 1; //Emboque legal. El jugador tiene otra oportunidad
            //return 0; //Se acabó el juego: embocó 8 bolas legal o ilegalmente. Establecer detalles del ganador
            //return 2; //Emboqueo ilegal. El oponente tiene la bola blanca en la mano.
        }
    }
}

