extends CSGBox3D

@export var friction := INF
@export var destination : Vector3 = Vector3.ZERO
@export var move_speed := 1.0

var base_position := Vector3.ZERO
var target := 1

func _ready() -> void:
	base_position = position

func _process(delta: float) -> void:
	if position == base_position:
		target = 1
	if position == destination:
		target = -1
	if target == 1:
		position = lerp(position, destination, delta * move_speed)
	elif target == -1:
		position = lerp(position, base_position, delta * move_speed)
