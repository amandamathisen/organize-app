export interface Todo {
  id: number;
  title: string;
  isCompleted: boolean;
}

const base = "http://localhost:5204/api/todos";

export async function getTodos(): Promise<Todo[]> {
  const res = await fetch(base);
  return res.json();
}

export async function createTodo(title: string): Promise<Todo> {
  const res = await fetch(base, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ title, isCompleted: false }),
  });
  return res.json();
}

export function updateTodo(todo: Todo): Promise<void> {
  return fetch(`${base}/${todo.id}`, {
    method: "PUT",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(todo),
  }).then(() => {});
}

export function deleteTodo(id: number): Promise<void> {
  return fetch(`${base}/${id}`, { method: "DELETE" }).then(() => {});
}
