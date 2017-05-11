using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing.Utilities;

[RequireComponent(typeof(PostProcessingController))]
public class JJ_DOF_Focuser : MonoBehaviour {

	#region Enums and References

	public enum FocusMode {
		Transform,
		View
	}
	[SerializeField]
	public FocusMode focusMode;

	public PostProcessingController _controller;

	#endregion

	#region Properties

	[SerializeField] 
	private Transform _target;
	public Transform Target {
		get { return _target; }
		set { _target = value; }
	}

	[SerializeField]
	private float _offset = 0;
	public float Offset {
		get { return _offset; }
		set { _offset = value; }
	}

	[SerializeField]
	private float _distance;
	public float Distance {
		get { return _distance; }
		set { _distance = value; }
	}

	[SerializeField]
	private float _standardFocusDistance;
	public float StandardFocusDistance {
		get { return _standardFocusDistance; }
		set { _standardFocusDistance = value; }
	}
		

	[SerializeField]
	private float _speed = 10;
	public float Speed {
		get { return _speed; }
		set { _speed = value; }
	}

	[SerializeField]
	private bool _debug = false;
	public bool DebugMode {
		get { return _debug; }
		set { _debug = value; }
	}

	private float _velocity;

	#endregion


	private void Start () {
		if(!_controller) {
			_controller = GetComponent<PostProcessingController>();
		}
	}
	
	private void Update () {
		var d1 = _controller.depthOfField.focusDistance;
		var dt = Time.deltaTime;

		if(focusMode == FocusMode.Transform) {
			if (_target == null) return;
			var d2 = Vector3.Dot(_target.position - transform.position, transform.forward);
			var n1 = _velocity - (d1 - d2) * Speed * Speed * dt;
			var n2 = 1 + Speed * dt;
			_velocity = n1 / (n2 * n2);
			var d = d1 + _velocity * dt;

			_controller.depthOfField.focusDistance = d;
			if(_debug) 
				Debug.DrawRay(transform.position, _target.position, Color.red);
		}
		else if(focusMode == FocusMode.View) {
			RaycastHit hit;
			Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5f,0f));
			if(Physics.Raycast(ray, out hit)) {
				var d2 = Vector3.Dot(hit.point - transform.position, transform.forward);
				var n1 = _velocity - (d1 - d2) * Speed * Speed * dt;
				var n2 = 1 + Speed * dt;
				_velocity = n1 / (n2 * n2);
				var d = d1 + _velocity * dt;

				_controller.depthOfField.focusDistance = d;
				if(_debug) Debug.DrawRay(transform.position, hit.point, Color.red);
			}
			else {
					
				_controller.depthOfField.focusDistance = StandardFocusDistance;
				if(_debug) 
					Debug.DrawRay(transform.position, transform.forward * StandardFocusDistance, Color.blue);
			}
		}
	}

}
