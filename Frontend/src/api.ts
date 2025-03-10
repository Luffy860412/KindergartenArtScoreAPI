import axios from 'axios';

const api = axios.create({
  // 在開發環境中，Vite 會自動代理 /api 請求到後端
  baseURL: '/api',
});

export interface Student {
  id: number;
  name: string;
  class_name: string;
  art_score: number;
}

const apiClient = axios.create({
  baseURL: 'http://localhost:5173/api',
  headers: {
    'Content-Type': 'application/json',
  },
});

export const studentApi = {
  // 獲取所有學生
  getAll: async (): Promise<Student[]> => {
    const response = await apiClient.get('/students');
    return response.data;
  },

  // 獲取單個學生
  get: async (id: number): Promise<Student> => {
    const response = await apiClient.get(`/students/${id}`);
    return response.data;
  },

  // 創建學生
  create: async (student: Omit<Student, 'id'>): Promise<Student> => {
    const response = await apiClient.post('/students', student);
    return response.data;
  },

  // 更新學生
  update: async (id: number, student: Partial<Student>): Promise<void> => {
    const existingStudent = await apiClient.get(`/students/${id}`);
    const updatedStudent = {
      ...existingStudent.data,
      ...student,
      class_name: existingStudent.data.class_name // 保留原有的班級名稱
    };
    await apiClient.put(`/students/${id}`, updatedStudent);
  },

  // 刪除學生
  delete: async (id: number): Promise<void> => {
    await apiClient.delete(`/students/${id}`);
  },
};