//
//  ContentView.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 19/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI
import Apollo
import Network


class ImageData: ObservableObject {
    @Published var data: [GetImagesQuery.Data.GetImage]?
    init() {
        loadData()
    }
    func loadData() {
        Server.shared.apollo.fetch(query: GetImagesQuery()) { result in
            guard let data = try? result.get().data else { return }

            if let stuff = data.getImages?.compactMap({$0}) {
                self.data = stuff
            }

            switch result {
                case.success(let result):
                    print(result)
                case.failure(let error):
                    print(error)

            }
        }
    }
}

struct ContentView: View {
    private let bagelPink = UIColor(red: 0.95805620825129523, green: 0.28210045499878755, blue: 1, alpha: 1)
    
    @ObservedObject private var data = ImageData()
    
    init() {
        let navAppearance = UINavigationBar.appearance()
        navAppearance.barTintColor = bagelPink
        navAppearance.titleTextAttributes = [
            .font: UIFont(name: "Chalkboard SE", size: 20)!,
            .foregroundColor: UIColor.white
        ]
    }
    
    func thing () {
        data.loadData()
    }
    
    var body: some View {
        NavigationView {
            

            ScrollView {
                Text("Hello, World!")
                    .font(.title)
                
                VStack(alignment: .leading, spacing: 2){
                   
                    ForEach(data.data ?? [], id: \.id) { imageItem in
                        Text("Something \(imageItem.source)")
                    }
                }
            }
            
//            .onAppear { self.thing() }
            .navigationBarTitle("BagelGram", displayMode: .inline)
        }
        
    }
    
}

struct ContentView_Previews: PreviewProvider {
    static var previews: some View {
        ContentView()
    }
}

