using UnityEngine;

namespace Character
{
    public class CharacterBase : MonoBehaviour
    {
        [SerializeField] protected float speed;
        [SerializeField] protected Animator animator;
        
        protected readonly int Run = Animator.StringToHash("Run");

    }
}