using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; //sirve paragregar el ui y el canvas

public class DragWindow : MonoBehaviour, IDragHandler //IDragHandler sirve para la funcion drag en el interface
{
	[SerializeField] private RectTransform dragRectTransform;

	public void OnDrag(PointerEventData eventData)
	{
		dragRectTransform.anchoredPosition += eventData.delta; //el eventData.delta es para agregar valores de movimiento al mouse
	}

}

