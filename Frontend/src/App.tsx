import React, { useState, useEffect } from 'react';
import { Palette, Plus, Pencil, Trash2, Search, Star, Save, X, Sparkles } from 'lucide-react';
import { toast, Toaster } from 'react-hot-toast';
import { Student, studentApi } from './api';

function App() {
  const [students, setStudents] = useState<Student[]>([]);
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [currentStudent, setCurrentStudent] = useState<Student | null>(null);
  const [searchTerm, setSearchTerm] = useState('');
  const [isLoading, setIsLoading] = useState(false);
  const [originalClassName, setOriginalClassName] = useState<string | null>(null);

  // 獲取所有學生數據
  const fetchStudents = async () => {
    try {
      setIsLoading(true);
      const data = await studentApi.getAll();
      setStudents(data);
    } catch (error) {
      toast.error('獲取學生數據失敗');
      console.error('Error fetching students:', error);
    } finally {
      setIsLoading(false);
    }
  };

  useEffect(() => {
    fetchStudents();
  }, []);

  const handleAdd = () => {
    setCurrentStudent(null);
    setOriginalClassName(null); // 清除原始班級名稱
    setIsModalOpen(true);
  };

  const handleEdit = (student: Student) => {
    setCurrentStudent(student);
    setOriginalClassName(student.class_name); // 儲存原始班級名稱
    setIsModalOpen(true);
  };

  const handleDelete = async (id: number) => {
    try {
      await studentApi.delete(id);
      toast.success('刪除成功');
      fetchStudents();
    } catch (error) {
      toast.error('刪除失敗');
      console.error('Error deleting student:', error);
    }
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    const form = e.target as HTMLFormElement;
    const studentData: Partial<Student> = {
      name: (form.name as unknown as HTMLInputElement).value,
      art_score: parseInt((form.art_score as HTMLInputElement).value),
      class_name: currentStudent ? (originalClassName ?? '') : (form.class_name as unknown as HTMLInputElement).value // 使用原始班級名稱或新班級名稱，並處理 null 值
    };

    try {
      if (currentStudent) {
        await studentApi.update(currentStudent.id, studentData);
        toast.success('更新成功');
      } else {
        await studentApi.create(studentData as Student);
        toast.success('新增成功');
      }
      setIsModalOpen(false);
      fetchStudents();
    } catch (error) {
      toast.error(currentStudent ? '更新失敗' : '新增失敗');
      console.error('Error saving student:', error);
    }
  };

  const filteredStudents = students.filter(student =>
    student.name.toLowerCase().includes(searchTerm.toLowerCase()) ||
    student.class_name.toLowerCase().includes(searchTerm.toLowerCase())
  );

  const getScoreColor = (score: number) => {
    if (score >= 90) return 'text-green-500';
    if (score >= 80) return 'text-blue-500';
    if (score >= 70) return 'text-yellow-500';
    return 'text-red-500';
  };

  return (
    <div className="min-h-screen bg-gradient-to-br from-pink-50 via-blue-50 to-purple-50">
      <Toaster position="top-right" />
      <div className="container mx-auto px-4 py-8">
        <div className="bg-white/80 backdrop-blur-sm rounded-3xl shadow-xl p-8 border border-white/20">
          {/* Header */}
          <div className="flex items-center justify-between mb-10">
            <div className="flex items-center space-x-4">
              <div className="p-3 bg-gradient-to-br from-purple-500 to-pink-500 rounded-2xl shadow-lg">
                <Palette className="w-8 h-8 text-white" />
              </div>
              <div>
                <h1 className="text-3xl font-bold bg-gradient-to-r from-purple-600 to-pink-600 bg-clip-text text-transparent">
                  幼稚園美術成績管理
                </h1>
                <p className="text-gray-500 mt-1">激發創意，培養藝術天份</p>
              </div>
            </div>
            <button
              onClick={handleAdd}
              className="flex items-center px-6 py-3 bg-gradient-to-r from-purple-600 to-pink-600 text-white rounded-xl hover:from-purple-700 hover:to-pink-700 transition-all duration-300 shadow-lg hover:shadow-xl transform hover:-translate-y-0.5"
            >
              <Plus className="w-5 h-5 mr-2" />
              新增學生
            </button>
          </div>

          {/* Search Bar */}
          <div className="relative mb-8">
            <Search className="absolute left-4 top-1/2 transform -translate-y-1/2 text-gray-400 w-5 h-5" />
            <input
              type="text"
              placeholder="搜尋學生或班級..."
              className="w-full pl-12 pr-4 py-3 bg-white/50 backdrop-blur-sm border border-gray-200 rounded-xl focus:outline-none focus:ring-2 focus:ring-purple-500 transition-all duration-300"
              value={searchTerm}
              onChange={(e) => setSearchTerm(e.target.value)}
            />
          </div>

          {/* Table */}
          <div className="overflow-hidden rounded-2xl border border-gray-200 shadow-lg">
            <table className="w-full">
              <thead>
                <tr className="bg-gradient-to-r from-purple-50 to-pink-50">
                  <th className="px-6 py-4 text-left text-sm font-semibold text-gray-600">學生姓名</th>
                  <th className="px-6 py-4 text-left text-sm font-semibold text-gray-600">班級</th>
                  <th className="px-6 py-4 text-left text-sm font-semibold text-gray-600">美術成績</th>
                  <th className="px-6 py-4 text-left text-sm font-semibold text-gray-600">操作</th>
                </tr>
              </thead>
              <tbody className="bg-white divide-y divide-gray-100">
                {isLoading ? (
                  <tr>
                    <td colSpan={4} className="px-6 py-4 text-center text-gray-500">
                      載入中...
                    </td>
                  </tr>
                ) : filteredStudents.length === 0 ? (
                  <tr>
                    <td colSpan={4} className="px-6 py-4 text-center text-gray-500">
                      暫無數據
                    </td>
                  </tr>
                ) : (
                  filteredStudents.map((student) => (
                    <tr key={student.id} className="hover:bg-gray-50 transition-colors duration-200">
                      <td className="px-6 py-4 whitespace-nowrap">
                        <div className="flex items-center">
                          <Sparkles className="w-4 h-4 text-yellow-400 mr-2" />
                          <span className="font-medium">{student.name}</span>
                        </div>
                      </td>
                      <td className="px-6 py-4 whitespace-nowrap">
                        <span className="px-3 py-1 bg-purple-100 text-purple-700 rounded-full text-sm">
                          {student.class_name}班
                        </span>
                      </td>
                      <td className="px-6 py-4 whitespace-nowrap">
                        <div className="flex items-center">
                          <Star className={`w-4 h-4 mr-1 ${getScoreColor(student.art_score)}`} />
                          <span className={`font-semibold ${getScoreColor(student.art_score)}`}>
                            {student.art_score}
                          </span>
                        </div>
                      </td>
                      <td className="px-6 py-4 whitespace-nowrap">
                        <div className="flex space-x-3">
                          <button
                            onClick={() => handleEdit(student)}
                            className="p-1.5 bg-blue-50 text-blue-600 rounded-lg hover:bg-blue-100 transition-colors"
                          >
                            <Pencil className="w-4 h-4" />
                          </button>
                          <button
                            onClick={() => handleDelete(student.id)}
                            className="p-1.5 bg-red-50 text-red-600 rounded-lg hover:bg-red-100 transition-colors"
                          >
                            <Trash2 className="w-4 h-4" />
                          </button>
                        </div>
                      </td>
                    </tr>
                  ))
                )}
              </tbody>
            </table>
          </div>
        </div>
      </div>

      {/* Modal */}
      {isModalOpen && (
        <div className="fixed inset-0 bg-black/50 backdrop-blur-sm flex items-center justify-center">
          <div className="bg-white rounded-2xl p-8 w-full max-w-md shadow-2xl">
            <div className="flex justify-between items-center mb-6">
              <h2 className="text-2xl font-bold bg-gradient-to-r from-purple-600 to-pink-600 bg-clip-text text-transparent">
                {currentStudent ? '編輯學生資料' : '新增學生'}
              </h2>
              <button
                onClick={() => setIsModalOpen(false)}
                className="p-2 hover:bg-gray-100 rounded-full transition-colors"
              >
                <X className="w-5 h-5 text-gray-500" />
              </button>
            </div>
            <form onSubmit={handleSubmit} className="space-y-6">
              <div>
                <label className="block text-sm font-medium text-gray-700 mb-2">學生姓名</label>
                <input
                  type="text"
                  name="name"
                  required
                  defaultValue={currentStudent?.name}
                  className="w-full px-4 py-3 rounded-xl border border-gray-200 focus:outline-none focus:ring-2 focus:ring-purple-500 transition-all duration-300"
                  placeholder="請輸入學生姓名"
                />
              </div>
              {!currentStudent && (
                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-2">班級</label>
                  <input
                    type="text"
                    name="class_name"
                    required
                    className="w-full px-4 py-3 rounded-xl border border-gray-200 focus:outline-none focus:ring-2 focus:ring-purple-500 transition-all duration-300"
                    placeholder="請輸入班級名稱"
                  />
                </div>
              )}
              <div>
                <label className="block text-sm font-medium text-gray-700 mb-2">美術成績</label>
                <input
                  type="number"
                  name="art_score"
                  min="0"
                  max="100"
                  required
                  defaultValue={currentStudent?.art_score}
                  className="w-full px-4 py-3 rounded-xl border border-gray-200 focus:outline-none focus:ring-2 focus:ring-purple-500 transition-all duration-300"
                  placeholder="請輸入成績 (0-100)"
                />
              </div>
              <div className="flex justify-end space-x-3 pt-4">
                <button
                  type="button"
                  onClick={() => setIsModalOpen(false)}
                  className="px-6 py-3 border border-gray-200 rounded-xl text-gray-700 hover:bg-gray-50 transition-colors"
                >
                  取消
                </button>
                <button
                  type="submit"
                  className="flex items-center px-6 py-3 bg-gradient-to-r from-purple-600 to-pink-600 text-white rounded-xl hover:from-purple-700 hover:to-pink-700 transition-all duration-300 shadow-lg hover:shadow-xl"
                >
                  <Save className="w-4 h-4 mr-2" />
                  儲存
                </button>
              </div>
            </form>
          </div>
        </div>
      )}
    </div>
  );
}

export default App;