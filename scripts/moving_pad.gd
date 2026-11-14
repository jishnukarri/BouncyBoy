extends CSGBox3D

@export var friction := INF
@export var destination : Vector3 = Vector3.ZERO
@export var move_speed := 1.0

var base_position := Vector3.ZERO
var target := 1

func _ready() -> void:
	base_position = position

func _process(delta: float) -> void:
	if target == 1:
		position = position.move_toward(destination, move_speed * delta)
		if position.distance_to(destination) < 0.01:
			target = -1
	elif target == -1:
		position = position.move_toward(destination, move_speed * delta)
		if position.distance_to(base_position) < 0.01:
			target = 1  
