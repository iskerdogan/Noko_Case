using UnityEngine;

namespace Character
{
    public class Player : CharacterBase
    {
        [SerializeField] private DynamicJoystick dynamicJoystick;
        public void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector3 direction = Vector3.forward * dynamicJoystick.Vertical + Vector3.right * dynamicJoystick.Horizontal;
            if (direction.magnitude > .05f)
            {
                transform.LookAt(transform.position + direction);
                transform.position += direction * (speed * Time.deltaTime);
                animator.SetBool(Run,true);
            }
            else
            {
                animator.SetBool(Run,false);
            }
        }
    }
}
