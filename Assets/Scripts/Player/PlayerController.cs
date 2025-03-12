using UnityEngine;

namespace Player
{
	public class PlayerController : MonoBehaviour
	{
	    [SerializeField] private int _speed = 5;
	    
	    public Transform target;

	    void Update()
	    {
	        if (Input.GetKey(KeyCode.D)) {
	            transform.position += Vector3.right * _speed;
	        }

	        if (target == null) {
	        	target.transform.position = Vector3.zero;
	        }
	    }
	}
}