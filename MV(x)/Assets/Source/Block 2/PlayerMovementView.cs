using UnityEngine;

namespace Source.Block_2
{
    public class PlayerMovementView : MonoBehaviour
    {
        public void MovePlayer(Vector3 position)
        {
            transform.position = position;
        }
    }
}