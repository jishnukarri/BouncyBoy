extends CSGBox3D

@onready var collision: CollisionShape3D = $area/collision

@export var friction := INF
@export var axis : Vector3 = Vector3.ZERO
@export var spin_speed := 1.0

func _process(delta: float) -> void:
	match axis:
		"x":
			rotation.x += spin_speed * delta
		"y":
			rotation.y += spin_speed * delta
		"z":
			rotation.z += spin_speed * delta
