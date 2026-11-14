extends CSGBox3D

@onready var collision: CollisionShape3D = $area/collision

@export var friction := 1.0
@export var strength := 10.0

func _ready() -> void:
	collision.shape.size = self.size

func _on_area_body_entered(body: Node3D) -> void:
	if body.is_in_group("player"):
		body.velocity = strength
