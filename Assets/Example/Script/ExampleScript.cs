
using UnityEngine;

namespace Example
{
    public sealed class ExampleScript : MonoBehaviour
    {
        //----- params -----

        //----- field -----

        [SerializeField]
        private Animator animator = null;

        //----- property -----

        //----- method -----

        void OnGUI()
        {
            if (GUI.Button(new Rect(10f, 10f, 100f, 60f), "Animation"))
            {
                animator.Play("anim");
            }
        }
    }
}